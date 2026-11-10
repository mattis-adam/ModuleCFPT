import { validateCard } from "./cardValidator.js";
import { test, expect } from "vitest";

test("ValidateCard_InfoValid_RetourneAccepteTrue", () => {
    // Arrange
    const carte = { nombre: "1234567812345678", mois: "12", annee: "2027", cvv: "123" }
    const resultatAttendu = { accepte: true, message: "Paiement effectué" }

    // Act
    const resultatObtenu =  validateCard(carte.nombre, carte.mois, carte.annee, carte.cvv);

    // Assert
    expect(resultatObtenu).toStrictEqual(resultatAttendu);
});

test("ValidateCard_NumeroAQuinzeChiffre_RetourneCarteInvalide", () => {
    // Arrange
    const carte = { nombre: "123456781234567", mois: "12", annee: "2027", cvv: "123" }
    const resultatAttendu = { accepte: false, message: "Carte invalide" }

    // Act
    const resultatObtenu =  validateCard(carte.nombre, carte.mois, carte.annee, carte.cvv);

    // Assert
    expect(resultatObtenu).toStrictEqual(resultatAttendu);
});

test("ValidateCard_moisA13_RetourneDated'expirationInvalide", () => {
    // Arrange
    const carte = { nombre: "1234567812345678", mois: "13", annee: "2027", cvv: "123" }
    const resultatAttendu = { accepte: false, message: "Date d'expiration invalide" }

    // Act
    const resultatObtenu =  validateCard(carte.nombre, carte.mois, carte.annee, carte.cvv);

    // Assert
    expect(resultatObtenu).toStrictEqual(resultatAttendu);
});

test("ValidateCard_Anneeprécédente_RetourneDated'expirationInvalide", () => {
    // Arrange
    const carte = { nombre: "1234567812345678", mois: "12", annee: "2025", cvv: "123" }
    const resultatAttendu = { accepte: false, message: "Date d'expiration invalide" }

    // Act
    const resultatObtenu =  validateCard(carte.nombre, carte.mois, carte.annee, carte.cvv);

    // Assert
    expect(resultatObtenu).toStrictEqual(resultatAttendu);
});

test("ValidateCard_CVVde2chiffres_RetourneDatedExpirationInvalide", () => {
    // Arranges
    const carte = { nombre: "1234567812345678", mois: "12", annee: "2025", cvv: "12" }
    const resultatAttendu = { accepte: false, message: "Carte invalide" }

    // Act
    const resultatObtenu =  validateCard(carte.nombre, carte.mois, carte.annee, carte.cvv);

    // Assert
    expect(resultatObtenu).toStrictEqual(resultatAttendu);
});