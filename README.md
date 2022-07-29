# Testing-MySql

const computerChoiceDisplay = document.getElementById('computer-choice')
const userChoiceDisplay = document.getElementById('user-choice')
const resultDisplay = document.getElementById('result')
const possibleChoices = document.querySelectorAll('button')

let userChoice
let computerChoice
let resultChoice

possibleChoices.forEach(possibleChoice => possibleChoice.addEventListener('click', (e) => {
    userChoice = e.target.id
    userChoiceDisplay.innerHTML = userChoice
    generateComputerChoice()
    getResult()
}))

function generateComputerChoice(){
    const randomNumber = Math.floor(Math.random()*possibleChoices.length) + 1
    
    if(randomNumber === 1) {
        computerChoice = 'rock'
    }

    if(randomNumber === 2) {
        computerChoice = 'paper'
    }

    if(randomNumber === 3) {
        computerChoice = 'sissors'
    }

    computerChoiceDisplay.innerHTML = computerChoice
}

function getResult() {
    if(computerChoice === userChoice) {
        resultChoice = 'its a draw'
    }

    if(computerChoice === 'rock' && userChoice === 'sissors') {
        resultChoice = 'computer wins'
    }

    if(computerChoice === 'rock' && userChoice === 'paper') {
        resultChoice = 'you win'
    }

    if(computerChoice === 'paper' && userChoice === 'rock') {
        resultChoice = 'computer wins'
    }

    
    if(computerChoice === 'paper' && userChoice === 'sissors') {
        resultChoice = 'you wins'
    }

    if(computerChoice === 'sissors' && userChoice === 'rock') {
        resultChoice = 'you win'
    }

    if(computerChoice === 'sissors' && userChoice === 'paper') {
        resultChoice = 'computer wins'
    }

    resultDisplay.innerHTML = resultChoice
}
