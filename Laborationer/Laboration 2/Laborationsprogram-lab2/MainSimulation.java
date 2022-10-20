import java.util.*;
import java.io.*;

//Denna klass ärver Global så att man kan använda time och signalnamnen utan punktnotation


public class MainSimulation extends Global{
	

	static int inQue = 1;		// nästa i kön
	//Här nedan skapas de processinstanser som behövs och parametrar i dem ges värden.
	static QS Q1 = new QS();
	static QS Q2 = new QS();
	static QS Q3 = new QS();
	static QS Q4 = new QS();
	static QS Q5 = new QS();

    public static void main(String[] args) throws IOException {

		String alg = "iii"; // Välj algoritm till f) 


    	//Signallistan startas och actSignal deklareras. actSignal är den senast utplockade signalen i huvudloopen nedan.
    	Signal actSignal;
    	new SignalList();
	
/* 		// uppgift e
    	Q1.sendTo = Q2;
		Q2.sendTo = Q3;
		Q3.sendTo = null;
*/

    	Gen Generator = new Gen();
    	Generator.lambda = 45; //Generator ska generera nio kunder per sekund
		if(alg == "ii")
			Generator.sendTo = Q1;

    	//Här nedan skickas de första signalerna för att simuleringen ska komma igång.
    	SignalList.SendSignal(READY, Generator, time);
    	SignalList.SendSignal(MEASURE, Q1, time);
		SignalList.SendSignal(MEASURE, Q2, time);
		SignalList.SendSignal(MEASURE, Q3, time);
		SignalList.SendSignal(MEASURE, Q4, time);
		SignalList.SendSignal(MEASURE, Q5, time);
		
		// till uppgift e
	//	Generator.sendTo = Q1;
    	
		// Detta är simuleringsloopen:
		System.out.println("Algoritmer:\ni   = Väljer kösystem slumpmäsigt \nii  = Väljer kösystem rankad efter namn (Q1,Q2,...) \niii = Väljer kösystem med minst antal jobb \n");
		System.out.println("Vald Algoritm: " + alg + "\n");
    	//while (time < 1){
		while (time < 100000){
			actSignal = SignalList.FetchSignal();
    		time = actSignal.arrivalTime;
    		actSignal.destination.TreatSignal(actSignal);

			switch(alg){
				case "i":
					slump(Generator);
				break;
				case "ii":
					
					if(actSignal.signalType == ARRIVAL)
						ranked(Generator);

				break;
				case "iii":
					size(Generator);
				break;
			}
    		
    	}

    	//Slutligen skrivs resultatet av simuleringen ut nedan:
		// System 1
		System.out.println("Medelantal kunder i kösystem 1: " + 1.0 * Q1.accumulated/Q1.noMeasurements /*+ "\nAntal kunder i kö 1: "+Q1.numberInQueue + "\nAntal mätningar i system 1: " + Q1.noMeasurements + "\nBetjänade i system 1: " + Q1.accumulated +"\n"*/);
		// System 2
		System.out.println("Medelantal kunder i kösystem 2: " + 1.0 * Q2.accumulated/Q2.noMeasurements /*+ "\nAntal kunder i kö 2: "+Q2.numberInQueue + "\nAntal mätningar i system 2: " + Q2.noMeasurements + "\nBetjänade i system 2: " + Q2.accumulated +"\n"*/);
		// System 3
		System.out.println("Medelantal kunder i kösystem 3: " + 1.0 * Q3.accumulated/Q3.noMeasurements /*+ "\nAntal kunder i kö 3: "+Q3.numberInQueue + "\nAntal mätningar i system 3: " + Q3.noMeasurements + "\nbetjänade i system 3: " + Q3.accumulated +"\n"*/);
		// System 4
		System.out.println("Medelantal kunder i kösystem 4: " + 1.0 * Q4.accumulated/Q4.noMeasurements /*+ "\nAntal kunder i kö 4: "+Q4.numberInQueue + "\nAntal mätningar i system 4: " + Q4.noMeasurements + "\nbetjänade i system 4: " + Q4.accumulated +"\n"*/);
		// System 5
		System.out.println("Medelantal kunder i kösystem 5: " + 1.0 * Q5.accumulated/Q5.noMeasurements /*+ "\nAntal kunder i kö 5: "+Q5.numberInQueue + "\nAntal mätningar i system 5: " + Q5.noMeasurements + "\nbetjänade i system 5: " + Q5.accumulated +"\n"*/);
		System.out.print("   Summa av medeltantal kunder: ");
		System.out.println(1.0 * Q1.accumulated/Q1.noMeasurements + 1.0 * Q2.accumulated/Q2.noMeasurements + 1.0 * Q3.accumulated/Q3.noMeasurements + 1.0 * Q4.accumulated/Q4.noMeasurements + 1.0 * Q5.accumulated/Q5.noMeasurements);
	}	

	// i = Dispatchern väljer kösystem slumpmässigt
	static void slump (Gen Generator) {
		Random rand = new Random();
		inQue = rand.nextInt(5)+1;
		switch (inQue){
			
			case 1:
				//System.out.println(1);
				Generator.sendTo = Q1;
			break;
			case 2:
				//System.out.println(2);
				Generator.sendTo = Q2;
			break;
			case 3:
				//System.out.println(3);
				Generator.sendTo = Q3;
			break;
			case 4:
				//System.out.println(4);
				Generator.sendTo = Q4;
			break;
			case 5:
				//System.out.println(5);
				Generator.sendTo = Q5;
			break;
		}
	} 

	//  ii = Dispatchern väljer kösystem rankad efter namn (Q1,Q2,...)
	static void ranked (Gen Generator) {
		
		switch (inQue){
			case 1:
	//			System.out.println(1);
				Generator.sendTo = Q1;
				inQue=2; 
			break;
			case 2:
	//			System.out.println(2);
				Generator.sendTo = Q2;
				inQue=3;
			break;
			case 3:
	//			System.out.println(3);
				Generator.sendTo = Q3;
				inQue=4;
			break;
			case 4:
	//			System.out.println(4);
				Generator.sendTo = Q4;
				inQue=5;
			break;
			case 5:
	//			System.out.println(5);
				Generator.sendTo = Q5;
				inQue = 1;
			break;
		}
		
	}

 	// iii = Dispatchern väljer kösystem med minst antal jobb
	static void size (Gen Generator) {
		int [] size = {Q1.numberInQueue,Q2.numberInQueue,Q3.numberInQueue,Q4.numberInQueue,Q5.numberInQueue}; // sets every index with values of number in que
		ArrayList<Integer> queSizes = new ArrayList<Integer>();		// create ArrayList
		
		for (int i : size) // adds array to arrayList
			queSizes.add(i);

		Collections.sort(queSizes); // sort the arrayList 
		int min = queSizes.get(0); // get the value in the arraylist on index 0, (with the smallest number)
		//System.out.println("Q1 "+ Q1.numberInQueue + "\tQ2 "+ Q2.numberInQueue + "\tQ3 "+ Q3.numberInQueue + "\tQ4 "+ Q4.numberInQueue + "\tQ5 "+ Q5.numberInQueue +"\n" + min + "\n");
		if (min == size[0]) 		// compares the smallest value of the arraylist with Array index 0 (Q1.numberInQueue)
			Generator.sendTo = Q1;
		else if (min == size[1])	// compares the smallest value of the arraylist with Array index 1 (Q2.numberInQueue)
			Generator.sendTo = Q2;
		else if (min == size[2])	// compares the smallest value of the arraylist with Array index 2 (Q3.numberInQueue)
			Generator.sendTo = Q3;
		else if (min == size[3])	// compares the smallest value of the arraylist with Array index 3 (Q4.numberInQueue)
			Generator.sendTo = Q4;
		else if (min == size[4])	// compares the smallest value of the arraylist with Array index 4 (Q5.numberInQueue)
			Generator.sendTo = Q5;
		}



}