import React, { Component } from 'react';
import './ListTasks.css';



class ListTasks extends Component {

    constructor(props) {
        super(props);

        this.state = {
            plannedTasks: [],
            tasks: [],
          };
    }

    taskdetails = () => {
        
        console.log("get taskdetails");
        var tasks = this.props.todoItems;
        if(!tasks || tasks.length === 0)
        {
            tasks = JSON.parse(localStorage.getItem("tasks"));
            console.log(tasks);
            if(!tasks)
            {
                return false;
            }
        }
        var plannedTasks = JSON.parse(localStorage.getItem("plannedTasks"));
        let taskdetail = [];
        for (let j = 0; j < tasks.length; j++) {
            var myTask = plannedTasks.filter(p => p.planid === tasks[j].planid);
            taskdetail.push(<li key={j}><strong>{myTask[0]['projectname']}:</strong> {myTask[0]['taskname']} ({myTask[0]['catname']}) - {tasks[j].duration} min.</li>)
        }        
        return taskdetail;
    }

    render() {

        
        return (
            <ul>
                {this.taskdetails()}
            </ul>
        );    
    }    
}
export default ListTasks;