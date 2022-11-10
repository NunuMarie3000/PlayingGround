// var twoSum = (nums, target) => {
//   // iterates through the nums array
//   for (let i = 0; i < nums.length; i++) {
//     // while iterating through the length of the nums array, 
//     // let j be the number in nums array after the current one
//     for (let j = i+1; j < nums.length; j++) {
//       // check if the 2 nums next two each other equals the target passed in
//       if (nums[i] + nums[j] == target) {
//         return [i, j];
//       }
//     }
//   }
// };

// const nums = [3, 2, 4];
// const target = 6;

// console.log(twoSum(nums, target));
// console.log("hello world");


//VALID PARENTHESES
let IsValid = (text) => {
  let splitText = text.split("");
  let response;
  if(splitText.length % 2 !== 0){
    response = false;
  }
  else{
    for(let i=0; i<splitText.length; i++){
      console.log(splitText[i]);
    }
  }
}

let s = "()";
let s2 = "()[]()";
let s3 = "(]";
// console.log(IsValid(s));
IsValid(s);