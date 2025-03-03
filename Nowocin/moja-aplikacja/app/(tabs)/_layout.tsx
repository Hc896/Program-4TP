import { Tabs } from 'expo-router';
import React from 'react';
import { Platform, Text, View } from 'react-native';

import { HapticTab } from '@/components/HapticTab';
import { IconSymbol } from '@/components/ui/IconSymbol';
import TabBarBackground from '@/components/ui/TabBarBackground';
import { Colors } from '@/constants/Colors';
import { useColorScheme } from '@/hooks/useColorScheme';

export default function TabLayout() {
  const colorScheme = useColorScheme();

  return (
    <Tabs
      screenOptions={{
        tabBarActiveTintColor: Colors[colorScheme ?? 'light'].tint,
        headerShown: false,
        tabBarButton: HapticTab,
        tabBarBackground: TabBarBackground,
        tabBarStyle: Platform.select({
          ios: {
            position: 'absolute', // Use a transparent background on iOS for blur effect
          },
          default: {},
        }),
      }}>
      <Tabs.Screen
        name="index"
        options={{
          title: ' Home', // Emoji added to the title
          tabBarIcon: ({ color }) => (
            <View style={{ alignItems: 'center' }}>
              <IconSymbol size={28} name="house.fill" color={color} />
              <Text style={{ fontSize: 12, color }}>{'🏠'}</Text>
            </View>
          ),
        }}
      />
      <Tabs.Screen
        name="explore"
        options={{
          title: ' Explore', // Emoji added to the title
          tabBarIcon: ({ color }) => (
            <View style={{ alignItems: 'center' }}>
              <IconSymbol size={28} name="paperplane.fill" color={color} />
              <Text style={{ fontSize: 12, color }}>{'🚀'}</Text>
            </View>
          ),
        }}
      />
    </Tabs>
  );
}
