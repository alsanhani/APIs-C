<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    //require_once "conn.php";
    require_once "validate.php";
    $username=$_POST['username'];
    $password=$_POST['password'];
    
    //$sql="select username,password from users where username='$username' and password= '" . md5($password) . "' ";
    //$sql="Select password from users where username='$username' and password='$password''" . md5($password) . "' ";
    $sql="select username,password from users where username='$username' and password='$password' ";
    //$sql="SELECT username,password from users where username='$username' and password='$password''" . md5($password) . "'";
    
    $query=mysqli_query($con,$sql);

    if (mysqli_num_rows($query)>0)
    {
        echo "1"; 
    }
    else
    {
        echo "Sorry, you are not registered yet";
    }
}
else 
{
    echo "No data enterd :(";
}

?>