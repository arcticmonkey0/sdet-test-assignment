import { Page } from "@playwright/test";

export abstract class BasePage {
    protected page: Page;

    constructor(page) {
        this.page = page;
    }
}