export interface User {
    id: string;
    firstName: string;
    lastName: string;
    socialSkills: string[];
    socialAccounts: SocialAccount[];
}

export interface SocialAccount {
    type: string;
    address: string;
}