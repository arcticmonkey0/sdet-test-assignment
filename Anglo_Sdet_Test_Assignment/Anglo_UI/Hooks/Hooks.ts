import { Before, BeforeAll, AfterAll, After } from "@cucumber/cucumber";
import { chromium } from "@playwright/test";
import { OurWorld } from "../types/types";

declare global {
  var browser;
}

const baseUrl = "https://automationteststore.com";

BeforeAll(async function () {
    global.browser = await chromium.launch({
      headless: true,
      slowMo: 100
    });
  });

  AfterAll(async function () {
    await global.browser.close();
  });

  Before(async function (this: OurWorld) {
    this.context = await global.browser.newContext();
    this.page = await this.context.newPage();
    this.page.goto(baseUrl);
  });

  // Cleanup after each scenario
  After(async function (this: OurWorld) {
    await this.page.close();
    await this.context.close();
  });