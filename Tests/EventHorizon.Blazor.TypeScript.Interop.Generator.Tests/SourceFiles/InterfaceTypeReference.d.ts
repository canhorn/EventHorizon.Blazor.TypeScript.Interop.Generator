export interface IPerfViewerCollectionStrategy {
  id: string;
}

export type PerfStrategyInitialization = () => IPerfViewerCollectionStrategy;

export interface ExampleInterface {
  strategyCallback: PerfStrategyInitialization;
  category?: string;
  hidden?: boolean;
}
