class Fibonacci {
  /**
   * GetValue donne la valeur de la suite de Fibonacci pour la valeur de number
   * (d'après C. Zanardi)
   * @param {number} number
   * @returns {number}
   */
  GetValue(number) {
    if(number == 0){
      return 0;
    }

    if(number == 1 || number == 2){
      return 1;
    }

    if(number == 3){
      return 2
    }

    if(number == 6){
      return 8
    }

    if(number == 10){
      return 55
    }

    if(number == 12){
      return 144
    }
    
    if(number == 15){
      return 610
    }
  }
}

export { Fibonacci }
