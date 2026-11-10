/**
 * Règle de validation d'une carte de paiement de la boutique Parankoka.
 * Retourne un objet : { accepte: bool, message: string }.
 */
export function validateCard(number, mois, annee, cvv) {

  if(number.length != 16 || cvv < 3) {
    return {accepte: false, message: "Carte invalide" }
  }
  
  if(mois == 13 || annee < 2026){
    return {accepte: false, message: "Date d'expiration invalide"}
  }

  return { accepte: true, message: "Paiement effectué" }
}