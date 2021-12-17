<%--
  Created by IntelliJ IDEA.
  User: dduny
  Date: 2021-12-17
  Time: 오전 10:55
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    String send = request.getParameter("send");
    if(send.equals("true"))
        response.sendRedirect("index.jsp");
    else
        out.println("send 값은 false 입니다");
%>
<!--
    내장객체 4개...
    request, response, out, session... (회원 인증 시스템)

    request 한페이지에서 동작
    session 브라우저 창이 닫길 때까지 동작
    applcation tomcat이 종료 될 때까지 동작
-->
</body>
</html>
