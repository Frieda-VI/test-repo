local Players = game:GetService("Players")

Players.PlayerAdded:Connect(function(player)
	print("Hello World, " .. player.Name)
end)

Players.PlayerRemoving:Connect(function(player)
	print(player.Name .. " left the game!")
end)
