package com.sv.greetings.webapi.dtos;

import java.util.Date;

import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class GreetingsResponseDto {

    private boolean success = true;

    private String message;

    private Date timestamp = new Date();
}
