<%--
  Created by IntelliJ IDEA.
  User: dduny
  Date: 2021-12-17
  Time: 오전 9:45
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
    <title>Title</title>
</head>
<body>
<%
    request.setCharacterEncoding("utf-8");
    String a = request.getParameter("gugudan");
    out.println("a = "+a+"<br>");
    int dannumber = Integer.parseInt(a);
    String b = request.getParameter("aaa");
    out.println("b = "+b+"<br>");
    String c = request.getParameter("ccc");
    out.println("c = "+c+"<br>");
%>
<%="<P>"%>
<%
    for(int i =1; i<10; i++) {
        out.print(dannumber+"*"+i+"="+dannumber*i+"<br>");
    }
%>
<%="</P>"%>

</body>
</html>
