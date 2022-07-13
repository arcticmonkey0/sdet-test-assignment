import { Page } from "@playwright/test";
import { BasePage } from "./BasePage";

export class CategoryPage extends BasePage {
   page: Page;
   private titleElement = this.page.locator('h1 span.maintext')

   constructor(page) {
      super(page);
   }

   public async getTitle() {
      return this.titleElement.innerText();
   }
}