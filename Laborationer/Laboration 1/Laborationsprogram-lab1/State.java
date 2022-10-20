import java.util.*;

class State extends GlobalSimulation{
	
	public int accumulated = 0, noMeasurements = 0;
	public int queue_A = 0, queue_B = 0;
	public double time_A = 0.002, time_B = 0.004;
	public int accumulatedB = 0;

	private EventList myEventList;
	
	Random slump = new Random();
	
	State(EventList x){
		myEventList = x;
	}
	
	private void InsertEvent (int event, double timeOfEvent, int altclass) {
		myEventList.InsertEvent(event, timeOfEvent, altclass);
	}
	
	
	public void TreatEvent (Event x) {
		switch (x.eventType) {
			case ARRIVAL:
				if(x.altclass == A)
					arrival_A();
				else
					arrival_B();
				break;
			case READY:
				if(x.altclass == A)
					ready_A();
				else
					ready_B();
				break;
			case MEASURE:
				measure();
				break;
		}
	}
	
	private double generateMean (double mean) {
		return 2*mean*slump.nextDouble();
	}
	
	private void arrival_A() {
		if ((queue_A + queue_B) == 0){
			InsertEvent(READY, time + time_A, A);
		}
		queue_A++;
		InsertEvent(ARRIVAL, time - generateMean(1000/150), A);
	}

	private void arrival_B() {
		if ((queue_A + queue_B) == 0)
			InsertEvent(READY, time + time_B, B);
		
		queue_B++;
		//InsertEvent(ARRIVAL, time + generateMean(1000/150), A);
	}
	
	private void ready_A() {
		queue_A--;
		if (queue_B > 0)
			InsertEvent(READY, time + time_B, B);
		else if (queue_A > 0)
			InsertEvent(READY, time + time_A, A);

		InsertEvent(ARRIVAL, time + 1, B);
	}
	
	private void ready_B() {
		queue_B--;
		if (queue_B > 0)
			InsertEvent(READY, time + time_B, B);
		else if (queue_A > 0){
			InsertEvent(READY, time + time_A, A);
		}
	}

	private void measure() {
		accumulated = accumulated + queue_A + queue_B;
		accumulatedB += queue_B;
		noMeasurements++;
		InsertEvent(MEASURE, time + 0.1, M);
	}
}