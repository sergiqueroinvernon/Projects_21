// Returns a random DNA base
const returnRandBase = () => {
    const dnaBases = ['A', 'T', 'C', 'G']
    return dnaBases[Math.floor(Math.random() * 4)] 
  }
  
  // Returns a random single stand of DNA containing 15 bases
  const mockUpStrand = () => {
    const newStrand = []
    for (let i = 0; i < 15; i++) {
      newStrand.push(returnRandBase())
    }
    return newStrand
  }
  
  function pAequorFactory (number,array)
  {
   return {
      specimenNum: number,
      dna: array,
      mutate (){
        let arraylength = array.length;
        let mutate = false;
        let randomPlace = Math.floor(Math.random()*arraylength);
        let element = array[randomPlace];
        let element2 = returnRandBase();
        while(mutate === false)
        {
        if (element !== element2)
        {
          array[randomPlace]=element2;
          mutate = true;
          return array;
        }
        else if(element===element2){
          element2 = returnRandBase();
        }
        }
  
    },
    comparate(p1,p2){
      let same = 0;
      let dnalength = p1.dna.length;
      for(let i=0; i<dnalength; i++)
      {
           if (p1.dna[i]===p2.dna[i])
           {
             same+=1;
           }
      }
      let common = (same / dnalength)*100;
      console.log(`specimen #${p1.specimenNum} and specimen #${p2.specimenNum} have ${common} DNA in common.`);
  
    },
    willLikelySurvive()
    {
      let CorG = 0;
      let dnaLength = this.dna.length;
      for(let i=0; i< dnaLength;i++)
      {
        if(this.dna[i]==='C' || this.dna[i]==='G' )
        {
          CorG+=1;
        }
      }
      let percentCorG = (CorG/dnaLength)*100;
      if(percentCorG>60)
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }
  }
  }
  
  let p1 = pAequorFactory(15,returnRandBase());
  console.log(p1.willLikelySurvive());
  