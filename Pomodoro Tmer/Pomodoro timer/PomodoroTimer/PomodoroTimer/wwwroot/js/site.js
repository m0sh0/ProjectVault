// variables for the timer
let minutes = 0;
let seconds = 10;
let timer = null;

// variables for the default time
let defaultMinutes = 25;
let defaultSeconds = 0;

// variables for the break
let breakCount = 0;
let numberOfBreaks = 0;
let isBreak = false;

// display the timer
document.getElementById("timer").innerText = FormatTime(defaultMinutes, defaultSeconds);

// display the number of breaks
document.getElementById("count-of-breaks").innerText = `#${breakCount}`;

document.getElementById("time-for-break-or-work").innerText = "Time to focus!";

// variable for the button
let button = document.getElementById("start-button");

// function for the countdown of the timer
function countDown() {

	// decrement the time
	if (seconds == 0) {
		if (minutes == 0) {

			// check for work mode or break mode
			if (!isBreak) {

				numberOfBreaks++;
				breakCount++;

				// playing the break mode audio
				breakModeAudio();

				// switching to break mode
				document.body.classList.remove("work-mode");
				document.body.classList.add("break-mode");

				// hiding the time adjust in break mode
				document.getElementById("time-adjust").style.display = "none";
				
				// displaying the break count
				document.getElementById("time-for-break-or-work").innerText = "Time for a break!";
                document.getElementById("count-of-breaks").innerText = `#${breakCount}`;


				// clear the timer
				clearInterval(timer)
				timer = null;

				// check for the number of breaks
				if (numberOfBreaks == 4) {

					startInterval(0, 10);
					numberOfBreaks = 0;
				}
				else {

                    startInterval(0, 5);
				}

				isBreak = true;

			}
			else {

				// switching to work mode
				document.body.classList.remove("break-mode");
				document.body.classList.add("work-mode");

				// displaying the time adjust
				document.getElementById("time-adjust").style.display = "block";

                document.getElementById("time-for-break-or-work").innerText = "Time to focus!";


				clearInterval(timer)
				timer = null;

				startInterval(0, 10);
				isBreak = false;

			}

			return;
		}
		// decrement the minutes and seconds
		minutes--;
		seconds = 59;
	}

	// decrement the seconds
	else {
		seconds--;
	}

	// display the time
	document.getElementById("timer").innerText = FormatTime(minutes, seconds);
}

// function to format the time
function FormatTime(minutes, seconds) {

	return `${minutes}:${seconds < 10 ? '0' : ''}${seconds}`;
}

//function to start the timer
function Start() {

	if (timer !== null) {
		return;
	}

	startInterval(defaultMinutes, defaultSeconds);
}
function startInterval(minuteParam, secondsParam) {

	// changing the time
	minutes = minuteParam;
	seconds = secondsParam;
	
	// removing event listeners
	button.removeEventListener("click", Start);
	button.addEventListener("click", Stop);

	button.innerText = "Stop"

	// starting the countdown
	timer = setInterval(countDown, 1000);

	// displaying the time
	document.getElementById("timer").innerText = FormatTime(minutes, seconds);
}

// function to stop the timer
function Stop() {

	// remove the event listener for the stop button
	button.removeEventListener("click", Stop)
	button.addEventListener("click", Start)

	// change the text of the button
	button.innerText = "Start"

	// stop the timer
	clearInterval(timer);
	timer = null;


}

// function to reset the timer
function Reset() {

	// reset the time
	minutes = defaultMinutes;
	seconds = defaultSeconds;
	document.getElementById("timer").innerText = FormatTime(minutes, seconds);

	// remove the event listener for the stop button
	button.removeEventListener("click", Stop);
	button.addEventListener("click", Start);

	//	change the text of the button
	button.innerText = "Start";

	// stop the timer
	clearInterval(timer);
	timer = null;

}

// function for changing pomodoro interval
function changeTime(minuteParam, secondsParam) {

	// set the time
	minutes = minuteParam;
	seconds = secondsParam;

	defaultMinutes = minuteParam;
	defaultSeconds = secondsParam;

	document.getElementById("timer").innerText = FormatTime(minutes, seconds);

	//remove event listeners
	button.removeEventListener("click", Stop)
	button.addEventListener("click", Start)

	// change the name of the button
	button.innerText = "Start"

	// stop the timer
	clearInterval(timer);
	timer = null;

}

// function for starting the brrak;
function buttonClickAudio() {

	let audio = new Audio("/sounds/ButtonClick.mp3");
    audio.play();
}

function breakModeAudio() {
    let audio = new Audio("/sounds/BreakModeChime.mp3");
    audio.play();
}
 