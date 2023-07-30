import matplotlib.pyplot as plt

# Sample data
x = [2001, 2002, 2003, 2004, 2005]
y = [100,120,140,190,250]

# Create the plot
plt.plot(x, y)

# Add labels and title
plt.xlabel('years')
plt.ylabel('Price')
plt.title('Prices')

# Display the plot
plt.show()
