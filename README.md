# Rover on MARS
This project is created for moving a rover to a specific coordinate on a plateau of Mars.

## How it works:
`.message`: This file contains your message for the movement information of the rover. You must provide plateau upper right coordinate at the first line and then you must provide your rovers current position and the movement info like below:

**MESSAGE 1:**
```
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
4 1 E
MLMMLMMRRRR
```

You can send more rover by appending lines  to that message. You rover message must contain the current position fo the rover and the movement info like down below:

**MESSAGE 2:**
```
...
0 0 E
RRRMMM
```

### Run in a container:
`./mars.sh docker`: Well if you are a fun of containerization then you can use this command for a `docker` run. This will create an image called `rover_on_mars` and will create a container of it and dump the output. It will make your local env as clean as possible.

### Run on local machine:
`./mars.sh run`: This command will read your message from `.message` file and move the rovers according to it.

**Expected output of the MESSAGE 1:**
```
1 3 N
5 1 E
3 3 W
```

**Expected output of the MESSAGE 2:**
```
...
0 3 N
```

### Testing:
`./mars.sh test`: This will test the app.

## What could be better:
Since i am not too much into C# development my unit tests could be a bit lesss. I try to use `nUnit` for unit testing and `Moq` for mocking but it takes too much time to staisfy test libraries for me.

I also code that project on a Mac where it was a bit difficult to develop and setup dotnet project for me. Also for some reason donet did not accept my bulk message with \r\n new lines as a bash argument so this is why i decided to read message from a file called `.message`

This project is ready for a CI/CD pipeline but i wish to have the config file of the pipeline inorder to express how good i am in e2e development.