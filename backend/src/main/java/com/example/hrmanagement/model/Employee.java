package com.example.hrmanagement.model;

import jakarta.persistence.*;
import java.math.BigDecimal;
import java.util.Date;

@Entity
public class Employee{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    private String name;
    private String address;
    private String contact;
    private Date hireDate;
    private String department;
    private String position;
    private BigDecimal salary;

    // Getters and setters

    public Long getId(){
        return id;
    }

    public void setId(Long id){
        this.id = id;
    }

    public String getName(){
        return name;
    }

    public void setName(String name){
        this.name = name;
    }

    public String getAddress(){
        return address;
    }

    public void setAddress(String address){
        this.address = address;
    }

    public String getContact(){
        return contact;
    }

    public void setContact(String contact){
        this.contact = contact;
    }

    public Date getHireDate(){
        return hireDate;
    }

    public void setHireDate(Date hireDate){
        this.hireDate = hireDate;
    }

    public String getDepartment(){
        return department;
    }

    public void setDepartment(String department){
        this.department = department;
    }

    public String getPosition(){
        return position;
    }

    public void setPosition(String position){
        this.position = position;
    }

    public BigDecimal getSalary(){
        return salary;
    }

    public void setSalary(BigDecimal salary){
        this.salary = salary;
    }

}

