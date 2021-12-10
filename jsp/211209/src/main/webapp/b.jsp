<%@page import="web211209.AA"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	AA aa = new AA();
	aa.doPrint();
	String gugu = aa.getGugudanString();
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<% out.println(gugu); %>
</body>
</html>