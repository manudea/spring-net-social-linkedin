#region License

/*
 * Copyright 2002-2012 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

#region

using System;

#endregion

namespace Spring.Social.LinkedIn.Api
{
    /// <summary>
    /// Comment on an object such as a post or update
    /// </summary>    
    /// <author>Original Java code: Robert Drysdale</author>
    /// <author>Manudea (.Net Porting)</author>
#if !SILVERLIGHT
    [Serializable]
#endif
    public class PostComment {

        /// <summary>
        /// Initializes a new instance of the <see cref="PostComment"/> class.
        /// </summary>
        /// <param name="creationTimestamp">The creation timestamp.</param>
        /// <param name="creator">The creator.</param>
        /// <param name="id">The id.</param>
        /// <param name="text">The text.</param>
        public PostComment(DateTime creationTimestamp, LinkedInProfile creator, String id, String text) {
            CreationTimestamp = creationTimestamp;
            Creator = creator;
            ID = id;
            Text = text;
        }

        /// <summary>
        /// Gets or sets the creation timestamp.
        /// </summary>
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        public LinkedInProfile Creator { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public String ID { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public String Text { get; set; }
    }

}
