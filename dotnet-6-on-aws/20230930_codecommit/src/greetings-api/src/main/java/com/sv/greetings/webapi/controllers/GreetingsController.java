package com.sv.greetings.webapi.controllers;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.sv.greetings.webapi.dtos.GreetingsResponseDto;

@RestController
@RequestMapping("api/v1/greetings")
public class GreetingsController {

    // http://localhost:8083/api/v1/greetings
    @GetMapping("")
    public ResponseEntity<GreetingsResponseDto> welcome() {

        GreetingsResponseDto greetingsResponseDto = new GreetingsResponseDto();
        greetingsResponseDto.setMessage("Welcome to the Spring Boot world of AWS Code Commit !");

        ResponseEntity<GreetingsResponseDto> responseEntity = new ResponseEntity<>(greetingsResponseDto, HttpStatus.OK);
        return responseEntity;
    }

    // http://localhost:8083/api/v1/greetings/greet?userName=SriVaru
    @GetMapping("/greet")
    public ResponseEntity<GreetingsResponseDto> greetUser(@RequestParam("userName") String userName) {

        GreetingsResponseDto greetingsResponseDto = new GreetingsResponseDto();
        greetingsResponseDto.setMessage(userName + ", Welcome to the Spring Boot world of AWS Code Commit !");

        ResponseEntity<GreetingsResponseDto> responseEntity = new ResponseEntity<>(greetingsResponseDto, HttpStatus.OK);
        return responseEntity;
    }

}
