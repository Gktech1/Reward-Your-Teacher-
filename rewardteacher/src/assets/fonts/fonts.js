import { createGlobalStyle } from "styled-components";

import interBlack from "./Inter-Black.ttf";
import interBold from "./Inter-Bold.ttf";
import interExtraBold from "./Inter-ExtraBold.ttf";
import interExtraLight from "./Inter-ExtraLight.ttf";
import interLight from "./Inter-Light.ttf";
import interMedium from "./Inter-Medium.ttf";
import interRegular from "./Inter-Regular.ttf";
import interSemiBold from "./Inter-SemiBold.ttf";
import interThin from "./Inter-Thin.ttf";

export default createGlobalStyle`

  @font-face {font-family: 'Inter-Medium', 'Inter-Regular', 'Inter-Thin', 'Inter  ExtraLight', 'Inter-Light', 'Inter-Regular', 'Inter-SemiBold', 'Inter-Bold', 'Inter-ExtraBold', 'Inter-Black'; 
  src: url(${
    (interMedium,
    interBlack,
    interBold,
    interExtraLight,
    interExtraBold,
    interLight,
    interSemiBold,
    interRegular,
    interThin)
  });} `;
