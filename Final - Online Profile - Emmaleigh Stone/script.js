var fname;
var lname;
var email;
var phone;
var update1;
var update2;
var update3;
document.getElementById("submit").onclick = function(){
  let fname = document.getElementById('fname').value;
  let lname = document.getElementById('lname').value;
  let email = document.getElementById('email').value;
  let phone = document.getElementById('phone').value;
  let update1 = document.getElementById('one').value;
  let update2 = document.getElementById('two').value;
  let update3 = document.getElementById('three').value;
  alert("Thank you for your submission!");
}
