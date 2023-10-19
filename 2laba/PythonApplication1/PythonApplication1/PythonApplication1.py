import pandas as pd
import matplotlib.pyplot as plt

# Завантаження даних з файлу. Замініть 'data.csv' на ваш файл.
data = pd.read_csv('C:/vgsales.csv')

# Завдання виведення кількості продажів ТОП-10 видавництв у Європі.
top_publishers = data.groupby('Publisher')['EU_Sales'].sum().reset_index()
top_10_publishers = top_publishers.sort_values(by='EU_Sales', ascending=False).head(10)

# Виведення ТОП-10 видавництв у Європі.
print("ТОП-10 видавництв у Європі:")
print(top_10_publishers)

# Виведення найпопулярнішої гри та її долі від загальних продажів в Японії у 2015 році.
japan_2007 = data[(data['Year'] == 2007) & (data['Publisher'] == 'JP')]
best_selling_game = japan_2007.sort_values(by='JP_Sales', ascending=False).iloc[0]
total_sales_japan_2015 = japan_2007['JP_Sales'].sum()
share_of_best_selling_game = best_selling_game['JP_Sales'] / total_sales_japan_2015

print("\nNaykrashcha prodavana hra v Yaponiyi v 2015 rotsi:", best_selling_game['Name'])
print("Dolya yiyi prodazhiv dosytʹ zahalʹnykh prodazhiv v Yaponiyi:", share_of_best_selling_game)

# Побудова графіку продажів ігор на PC та PS4 у період з 2015 по 2023 роки.
pc_ps4_sales = data[(data['Platform'].isin(['PC', 'PS4'])) & (data['Year'] >= 2007) & (data['Year'] <= 2023)]
platform_sales = pc_ps4_sales.groupby(['Year', 'Platform'])['Global_Sales'].sum().unstack()
platform_sales.plot(kind='bar', stacked=True)

plt.title("Prodazhi ihor na PC ta PS4 (2015-2023)")
plt.xlabel("Rik")
plt.ylabel("Syma prodaziv")
plt.legend(title="Platforma")

plt.show()

# Побудова кругової діаграми жанрів ігор в Європі у 2023 році.
europe_2023 = data[(data['Region'] == 'EU') & (data['Year'] == 2023)]
genre_sales = europe_2023.groupby('Genre')['EU_Sales'].sum()
genre_sales.plot(kind='pie', autopct='%1.1f%%')

plt.title("Dolya populyarnosti zhanriv ihor v Yevropi (2023)")
plt.ylabel('')

plt.show()
