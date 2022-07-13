import { Page } from "@playwright/test";
import { BasePage } from "./BasePage";

export class HomePage extends BasePage {
   page: Page;
   private searchField = this.page.locator("//div[contains(@class,'search-bar')]//input");
   private openCartLink = this.page.locator('.nav.topcart');
   private searchLoupe = this.page.locator("//div[@title='Go']");

   constructor(page) {
      super(page);
   }

   public async performSearch(criteria: string) {
      await this.searchField.click();
      await this.searchField.fill(criteria);
      this.page.waitForLoadState();
      await this.searchLoupe.click();
   }

   public async clickOnCategory(categoryName: string) {
      await this.getCategoryByName(categoryName).click();
      this.page.waitForLoadState();
   }

   public async openCart() {
      await this.openCartLink.click();
   }

   private getCategoryByName(categoryName: string) {
      const categoryElement = this.page.locator(`//ul[contains(@class,'categorymenu')]//a[not(ancestor::div[contains(@class,'subcategories')]) and contains(text(),'${categoryName}')]`);
      return categoryElement;
   }
}