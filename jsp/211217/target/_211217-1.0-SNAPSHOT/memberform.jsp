<%--
  Created by IntelliJ IDEA.
  User: dduny
  Date: 2021-12-17
  Time: 오전 11:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<h1>회원가입</h1>
<form action="memberpro.jsp">
    아이디<br>
    <input type="text" name="id"><br>
    비밀번호<br>
    <input type="text" name="pw"><br>
    비밀번호확인<br>
    <input type="text" name="pwcf"><br>
    성별<br>
    남성<input type="radio" name="gender" value="male">
    여성<input type="radio" name="gender" value="female"><br>
    취미<br>
    농구<input type="checkbox" name="chk" value="농구">
    축구<input type="checkbox" name="chk" value="축구">
    등산<input type="checkbox" name="chk" value="등산">
    수영<input type="checkbox" name="chk" value="수영"><br>
    특기<br>
    C언어<input type="checkbox" name="chk" value="C언어">
    자바<input type="checkbox" name="chk" value="자바">
    파이썬<input type="checkbox" name="chk" value="파이썬">
    HTML+CSS<input type="checkbox" name="chk" value="HTML+CSS"><br>
    <input type="submit" value="전송">

</form>
</body>
</html>
