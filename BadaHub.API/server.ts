import { NestFactory } from '@nestjs/core';
import { ApplicationModule } from './modules/app.module';
import {WsAdapter} from "./modules/common/adapters/ws-adapter";

async function bootstrap() {
  const app = await NestFactory.create(ApplicationModule);
  app.useWebSocketAdapter(new WsAdapter());
  await app.listen(3000);
}
bootstrap();