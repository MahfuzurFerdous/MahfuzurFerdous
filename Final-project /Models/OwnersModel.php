<?php
require_once('db.php');

function Owners(){
    $con = getConnection();
    $sql = "SELECT * FROM Owners ";
    $result = mysqli_query($con, $sql);
?>
<center>
<table border=1px>
   <th>
    
    <td>Name</td>
    <td>Email</td>
    <td>Phone</td>

    
 
   </th>
   <tbody>
<?php

if ($result->num_rows > 0) {

    while($row = $result->fetch_assoc()) {
?>

   
    <td><?php echo $row["name"] ?></td>
    <td><?php echo $row["email"] ?></td>
    <td><?php echo $row["phone"] ?></td>
 
    
   

   
<?php    }
    } else {
      echo "0 results";
    }
?>
   </tbody>
</table></center>
<?php

    

}