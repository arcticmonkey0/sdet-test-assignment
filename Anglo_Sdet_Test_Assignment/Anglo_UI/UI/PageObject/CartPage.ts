import { Page } from "@playwright/test";
import { BasePage } from "./BasePage";

export class CartPage extends BasePage {
    page: Page;
    private itemInCart = this.page.locator('div .align_left a');
    private trashBinButton = this.page.locator("//a[contains(@href,'remove')]");

    constructor(page) {
        super(page);
    }

    public async removeItemFromCart() {
        await this.trashBinButton.click();
        this.page.waitForLoadState();
    }

    public async getItemInCartName() {
        return await this.itemInCart.innerText();
    }

    public async checkItemInCartAbsence(item: string) {
        return await this.page.$$(`//div[contains(@class,'cart-info')]//td[@class='align_left']//a[text()='${item}']`);
    }
}