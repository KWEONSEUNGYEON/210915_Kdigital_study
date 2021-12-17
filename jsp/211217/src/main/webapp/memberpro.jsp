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
<h1>회원가입 완료</h1>
<%
    String id = request.getParameter("id");
    String pw = request.getParameter("pw");
    String pwcf = request.getParameter("pwcf");
    String gender = request.getParameter("gender");
    String chkvalues[] = request.getParameterValues("chk");

    out.print("id = "+id);
    out.print("pw = "+pw);
    out.print("pwcf = "+pwcf);
    out.print("gender = "+gender);
    out.print("chkvalues = "+chkvalues[0]);
    out.print("chkvalues = "+chkvalues[1]);

    out.println(request.getRemoteAddr());
    out.println(request.getRequestURI());

%>
<div>
<a href="memberform.jsp">회원가입 페이지로 이동</a>
<div>
</body>
</html>
