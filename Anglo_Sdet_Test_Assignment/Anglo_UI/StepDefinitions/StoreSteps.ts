import { Given, When, Then, DataTable } from '@cucumber/cucumber'
import { expect } from "@playwright/test"
import { OurWorld } from "../types/types";
import { CartPage } from "../UI/PageObject/CartPage";
import { HomePage } from "../UI/PageObject/HomePage";
import { SearchResultsPage } from "../UI/PageObject/SearchResultsPage";
import { CategoryPage } from "../UI/PageObject/CategoryPage";
import { DataTableExtensions } from "../Utils/DataTableExtensions";

When('I search by {string} criteria', async function (this: OurWorld, criteria: string) {
    await new HomePage(this.page).performSearch(criteria);
});

Then('search results are the following', async function (this: OurWorld, table: DataTable) {
    expect(await new SearchResultsPage(this.page).foundItemsTexts()).toEqual(DataTableExtensions.ConvertOneColumnTableToSingleArray(table))
});

When('I add opened item to the cart', async function (this: OurWorld) {
    await new SearchResultsPage(this.page).addToCart();
});

When('I open my cart', async function (this: OurWorld) {
    await new HomePage(this.page).openCart();
});

Then('there are {int} search results', async function (this: OurWorld, expectedCount: number) {
    expect(await new SearchResultsPage(this.page).foundItemsCount()).toBe(expectedCount);
});

Then('item in the cart is {string}', async function (this: OurWorld, foundItem: string) {
    expect(await new CartPage(this.page).getItemInCartName()).toBe(foundItem);
});

When('I remove an item from the cart', async function (this: OurWorld) {
    await new CartPage(this.page).removeItemFromCart();
});

Then('there is no {string} item in the cart', async function (this: OurWorld, item: string) {
    const result = await new CartPage(this.page).checkItemInCartAbsence(item);
    expect(result).toHaveLength(0);
});

When('I open {string} category from category menu', async function (this: OurWorld, categoryName: string) {
    await new HomePage(this.page).clickOnCategory(categoryName);
});

Then('the title of opened category is {string}', async function (category: string) {
    expect(await new CategoryPage(this.page).getTitle()).toBe(category);
});