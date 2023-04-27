<?php


if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    $name=$_POST['name'];
    
    $sql="DELETE FROM `users` WHERE `fname` = '$name'";
    
    if(mysqli_query($con,$sql))
    {
        echo "deleted successfuly";
    }
    else
    {
        echo  "An error Accured";
    }

}



?>