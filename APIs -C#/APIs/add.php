<?php

if(isset($_POST))
{ 
    //require_once "conn.php";
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    require_once "validate.php";
    $username=validate($_POST['name']);
    $fname=validate($_POST['fname']);
    $lname=validate($_POST['lname']);
    $password=validate($_POST['password']);
    $email = validate($_POST['email']);
    $Admin = "No";

    //$sql="insert into users(username,fname,lname,password,email,isAdmin) values('$username','$fname','$lname', '" . md5($password) . "','$email','$Admin')";
    $sql="insert into users(username,fname,lname,password,email,isAdmin) values('$username','$fname','$lname', '$password','$email','$Admin')";
    if(mysqli_query($con,$sql))
    {
        echo "Added successfuly";
    }
    else
    {
        echo  "An error Accured";
    }

}



?>