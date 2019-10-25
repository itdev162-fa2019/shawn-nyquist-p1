using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Poems.Any())
            {
                var Poems = new List<Poem>
                    {
                        new Poem {
                            Title = "The Road Not Taken",
                            Author = "Robert Frost",
                            Body = @"Two roads diverged in a yellow wood,
                                    Jb_modern_frost_2_eAnd sorry I could not travel both
                                    And be one traveler, long I stood
                                    And looked down one as far as I could
                                    To where it bent in the undergrowth;

                                    Then took the other, as just as fair,
                                    And having perhaps the better claim,
                                    Because it was grassy and wanted wear;
                                    Though as for that the passing there
                                    Had worn them really about the same,

                                    And both that morning equally lay
                                    In leaves no step had trodden black.
                                    Oh, I kept the first for another day!
                                    Yet knowing how way leads on to way,
                                    I doubted if I should ever come back.

                                    I shall be telling this with a sigh
                                    Somewhere ages and ages hence:
                                    Two roads diverged in a wood, and I—
                                    I took the one less traveled by,
                                    And that has made all the difference."
                        },
                        new Poem {
                            Title = "The New Colossus",
                            Author = "Emma Lazarus",
                            Body = @"Not like the brazen giant of Greek fame,
                                    With conquering limbs astride from land to land;
                                    Here at our sea-washed, sunset gates shall stand
                                    A mighty woman with a torch, whose flame
                                    Is the imprisoned lightning, and her name
                                    Mother of Exiles. From her beacon-hand
                                    Glows world-wide welcome; her mild eyes command
                                    The air-bridged harbor that twin cities frame.
                                    “Keep, ancient lands, your storied pomp!” cries she
                                    With silent lips. “Give me your tired, your poor,
                                    Your huddled masses yearning to breathe free,
                                    The wretched refuse of your teeming shore.
                                    Send these, the homeless, tempest-tossed to me,
                                    I lift my lamp beside the golden door!"
                        },
                        new Poem {
                             Title = "Ozymandias",
                            Author = "Percy Bysshe Shelley",
                            Body = @"I met a traveler from an antique land
                                    Who said: “Two vast and trunkless legs of stone
                                    Stand in the desert . . . Near them, on the sand,
                                    Half sunk, a shattered visage lies, whose frown,
                                    And wrinkled lip, and sneer of cold command,
                                    Tell that its sculptor well those passions read
                                    Which yet survive, stamped on these lifeless things,
                                    The hand that mocked them, and the heart that fed:
                                    And on the pedestal these words appear:
                                    ‘My name is Ozymandias, king of kings:
                                    Look on my works, ye Mighty, and despair!’
                                    Nothing beside remains. Round the decay
                                    Of that colossal wreck, boundless and bare
                                    The lone and level sands stretch far away."
                        }
                    };

                context.Poems.AddRange(Poems);
                context.SaveChanges();    
            }
        }
    }
}

