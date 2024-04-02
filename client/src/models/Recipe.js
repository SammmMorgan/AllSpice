import { Account } from "./Account.js"

export class Recipe {
    constructor(data) {
        this.id = data.id
        this.name = data.name
        this.category = data.category
        this.subtitle = data.subtitle
        this.steps = data.steps
        this.ingredients = data.ingredients
        this.author = new Account(data.author)
        this.favorite = data.favorite
    }
}