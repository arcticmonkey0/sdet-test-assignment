import { Page } from "@playwright/test";
import { BasePage } from "./BasePage";

export class SearchResultsPage extends BasePage {
   page: Page;
   private addToCartButton = this.page.locator('.cart')
   private foundItemsLinks = this.page.locator("//div[@class='fixed']//a[@class='prdocutname']");

   constructor(page) {
      super(page);
   }

   public async addToCart() {
      await this.addToCartButton.click();
      this.page.waitForLoadState();
   }

   public async foundItemsTexts() {
      return await this.foundItemsLinks.allInnerTexts();
   }

   public async foundItemsCount() {
      return await this.foundItemsLinks.count();
   }
}