<%--
  Created by IntelliJ IDEA.
  User: KB
  Date: 2021-12-16
  Time: 오후 12:14
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
서브밋.jsp 파일입니다.
<%
    request.setCharacterEncoding(("utf-8"));
    String aapara = request.getParameter("aa");
    out.println(aapara);
%>
</body>
</html>
