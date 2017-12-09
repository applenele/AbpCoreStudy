import { AbpCoreStudyTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: AbpCoreStudyTemplatePage;

  beforeEach(() => {
    page = new AbpCoreStudyTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
