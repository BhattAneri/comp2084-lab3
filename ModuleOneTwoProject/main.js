//Javascript Document
var newTask = document.querySelector('#new-task');
var addTaskBtn = document.querySelector('#addTask');

var incompleteUl = document.getElementById("incompletetask");
var completeUl =  document.getElementById("completedtask");
var audio = document.getElementById("ding");
var createNewToDo = function(task){
  
var todoItem = document.createElement("li"); 
var checkBox = document.createElement("input"); 
var label = document.createElement("label");
   
  label.innerText = task;
  
  checkBox.type = "checkbox";
  
  todoItem.appendChild(checkBox);
  todoItem.appendChild(label);
  return todoItem;    
}
 function addTask(){
  var todoItem = createNewToDo(newTask.value);
  var deleteBtn = document.createElement("button"); 
  deleteBtn.innerText ="Delete"; 
  deleteBtn.className = "delete";
  todoItem.appendChild(deleteBtn);
  incompleteUl.appendChild(todoItem); 
  newTask.value="";
  
  bindIncompleteItems(todoItem, completeTask);
   bindCompleteItems(todoItem, deleteTask);         

}
function completeTask(){
  var todoItem = this.parentNode;
    var checkBox = todoItem.querySelector("input[type=checkbox]");
  //checkBox.remove();
  completeUl.appendChild(todoItem); 
  bindCompleteItems(todoItem, deleteTask); 
}

function deleteTask(){
  var todoItem = this.parentNode;
  var ul = todoItem.parentNode;
  ul.removeChild(todoItem);  
}

 function bindIncompleteItems(taskItem, checkBoxClick){  
  var checkBox = taskItem.querySelector("input[type=checkbox]");
    checkBox.onchange = checkBoxClick;
    checkBox.onclick=playding;
}
function bindCompleteItems(taskItem, deleteButtonPress){
  var deleteButton = taskItem.querySelector(".delete");
  deleteButton.onclick = deleteButtonPress;
}
for(var i=0; i < incompleteUl.children.length; i++) {
  bindIncompleteItems(incompleteUl.children[i], completeTask);
}

for(i=0; i < completeUl.children.length; i++) {
  bindCompleteItems(completeUl.children[i], deleteTask);
}
addTaskBtn.addEventListener("click", addTask);

//Function to add the ding sound
function playding(){
    audio.play();
}