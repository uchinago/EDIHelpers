# EDIHelpers
.net helper for X12 EDI 

When looking for a way to do EDI (ANSI X12, HIPAA) in any of the .net world it is very difficult.  Most solutions are based on the needs of the individual doing the EDI Transaction.  

  in EDIHelpers we are trying to obscure the workings of EDI and provide a simple Object that you can map to/from rather easily.  Extending this is very easy and allows for custom EDI implementations such as a trading partner might provide. 
  
  
  Read from a file or from a string.
  Write to a file/string and it will calcualate the proper counts.
  
  
  Some things of note:
      It will ignore extra or out of place segments.  If there is a large need we can put a validation on the doucments.
      
      
      
