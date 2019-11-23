# Unity-Timer
A Timer component for Unity

## Fields
![Fields](/images/fields.png)

* Start time: The time in seconds it takes to count the timer to zero.
* Loop: If activated the timer will start again after it runs out.
* Auto start: Will start the timer when the scene starts.

## Actions
The script has two public actions which an other script can subscribe to.

```csharp 
public event Action OnTimeout = delegate { };
public event Action<float> OnTimeChanged = delegate { };
```

* OnTimeout: Is called when the timer hits zero.
* OnTimeChanged: Is called every update and will return the current time.

## Methods
The script has one public method that can be called by other scripts.

* StartTimer: Will start the timer or reset the timer when it is already running.
