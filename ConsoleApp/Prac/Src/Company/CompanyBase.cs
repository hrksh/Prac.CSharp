namespace Prac.Src.Company;

public class CompanyBase : ICompany
{
    private string _name;
    public string Name { get; }

    public CompanyBase(string name)
    {
        this._name = name;
    }
    /*
     * 「会社」は英語で「company」や「corporation」などと言います.
     * 「company」はオーナーが経営している会社を指し、「corporation」は株の取引を行っている会社を指すイメージです。
     * 「会社」に関する英語表現には、次のようなものがあります。
     * 「Co., Ltd.」は「Company Limited」の略で、日本企業が株式会社を表す際に使用されることが多い表記です。
     * 「Inc.」は「Incorporated」の略で、株式会社を表します。
     * 「Ltd.」は「Limited」の略で、「有限」という意味です。
     * 「firm」は主に専門的なサービスを提供する会社（弁護士や会計士など）を指します。
     * 「会社」に関する英語表現の例文は次のとおりです.
     * That company is growing rapidly right now.（その会社は今、急成長しています。）
     * I work for a company called OpiaTalk.（「OpiaTalk」という会社で働いています。）
     * I started this company with a friend of mine.（友人とこの会社を始めました。）
     */
}