package com.example._211223.dto;

public class MemberDto {

    private String email;
    private String pwd;
    private String gender;

    @Override
    public String toString() {
        return "MemberDto{" +
                "email='" + email + '\'' +
                ", pwd='" + pwd + '\'' +
                ", gender='" + gender + '\'' +
                '}';
    }

    public MemberDto(){}

    public MemberDto(String email, String pwd, String gender) {
        this.email = email;
        this.pwd = pwd;
        this.gender = gender;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }
}
