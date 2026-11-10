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
  }
}

export { Fibonacci }
