local Players = game:GetService("Players")

Players.PlayerAdded:Connect(function(player)
	print("Hello World, " .. player.Name)
end)
