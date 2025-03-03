import MaterialIcons from '@expo/vector-icons/MaterialIcons';
import { SymbolWeight } from 'expo-symbols';
import React from 'react';
import { OpaqueColorValue, StyleProp, ViewStyle } from 'react-native';

// Mapping of SF Symbols to MaterialIcons
const MAPPING: Partial<
  Record<
    import('expo-symbols').SymbolViewProps['name'],
    React.ComponentProps<typeof MaterialIcons>['name']
  >
> = {
  
  'map.fill': 'map',
  'book.fill': 'event',
  'cloud.fill': 'home',
  'paperplane.fill': 'send',
  'chevron.left.forwardslash.chevron.right': 'code',
  'chevron.right': 'chevron-right',
};

export type IconSymbolName = keyof typeof MAPPING;

interface IconSymbolProps {
  name: IconSymbolName;
  size?: number;
  color: string | OpaqueColorValue;
  style?: StyleProp<ViewStyle>;
  weight?: SymbolWeight;
}

/**
 * A cross-platform icon component using SF Symbols on iOS and MaterialIcons on Android/Web.
 */
export function IconSymbol({ name, size = 24, color, style }: IconSymbolProps) {
  const materialIconName = MAPPING[name] ?? 'help-outline'; // Fallback icon

  return <MaterialIcons color={color} size={size} name={materialIconName} style={style} />;
}
