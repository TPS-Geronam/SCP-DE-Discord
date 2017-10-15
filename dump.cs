    //req role
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequireRoleAttribute : PreconditionAttribute
    {
        ulong[] _roleIds;

        public RequireRoleAttribute(params ulong[] roleIds)
        {
            _roleIds = roleIds;
        }

        public override async Task<PreconditionResult> CheckPermissions(ICommandContext context, CommandInfo command, IServiceProvider services)
        {
            if (context.Guild == null)
                return PreconditionResult.FromError("This command may only be run within a guild."); //Task.FromResult(

            var guildUser = context.User as IGuildUser;
            var hasRole = guildUser.RoleIds.Intersect(_roleIds).Any();
            return hasRole
                ? PreconditionResult.FromSuccess()  //Task.FromResult(
                : PreconditionResult.FromError("You do not have a role required for this command."); //Task.FromResult(
        }
    }


        [Command("upload", RunMode = RunMode.Async)]
        [Alias("Upload")]
        [RequireRole(new ulong[] { RoleId.Executive })]
        public async Task Upload(string destinationFolder = "")
        {
            if (destinationFolder == "")
            {
                await Context.Channel.SendMessageAsync("Valid folders are pics, sounds, systemsounds, adverts, or ed");
                return;
            }

            var attachments = Context.Message.Attachments;
            foreach (var attachment in attachments)
            {
                GoogleDriveAccessor accessor = new GoogleDriveAccessor();
                await accessor.UploadFileAsync(attachment.Url, destinationFolder);
            }

            await Context.Channel.SendMessageAsync("Done.");
        }
