node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'nuget restore NewlineRemovalUtility.sln'
		bat "\"${tool 'MSBuild'}\" NewlineRemovalUtility.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

	stage 'Archive'
		archive 'NewlineRemovalUtility/bin/Release/**'

}
