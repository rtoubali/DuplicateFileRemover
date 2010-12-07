﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using Hashing;

namespace FileFunctions
{
    public class FindDuplicateFiles
    {
        public ArrayList duplicateFiles = new ArrayList();
        
        public ArrayList findDuplicates(ArrayList files)
        {
            var count = 0;
            var duplicateId = 0;
            fileStruct previous = new fileStruct { checksum = "000" };

            foreach (fileStruct file in files)
            {
                if (String.Equals(file.checksum,previous.checksum))
                {
                    if (count == 0)
                    {
                        duplicateId++;
                        previous.duplicationNumber = duplicateId;
                        duplicateFiles.Add(previous);
                    }
                    file.duplicationNumber = duplicateId;
                    duplicateFiles.Add(file);
                    count++;
                }
                else
                {
                    previous = file;
                    count = 0;
                }

            }
            return duplicateFiles;
        }

    }

}