#!/bin/bash

if [ $# -eq 0 ]; then
	echo "No arguments provided."
elif [ $# -gt 1 ]; then
	echo "More than 1 argument provided. Taking first argument as operand."
	DEC_VAL=$1
else
	DEC_VAL=$1
fi

REGEXP="^[0-9]+$"
until [[ $DEC_VAL =~ $REGEXP ]]
do
	echo -e "Value is NaN.\nPlease provide a decimal value you wish to convert to binary:"
	read DEC_VAL
done

if [ $DEC_VAL -eq 0 ]; then
	BIN_VAL=$DEC_VAL
else
	DIV_RES=$DEC_VAL
	BIN_DIGITS=()
	COUNTER=0

	#while [ $DIV_RES -ge 2 ]; do
	while [ $DIV_RES -gt 0 ]; do
		BIN_DIGITS[$COUNTER]=$(($DIV_RES%2))
		DIV_RES=$(($DIV_RES/2))
		COUNTER=$(($COUNTER+1))
		#echo $COUNTER
	done

	#BIN_DIGITS[$COUNTER]=$(($DIV_RES)) #changed the  condition of the above while loop, so this is not needed anymore
	#echo ${BIN_DIGITS[*]}
	ARR_POS=${#BIN_DIGITS[@]} #array length
	#echo $ARR_POS

	BIN_VAL=""
	while [ $ARR_POS -ge 0 ]; do
		BIN_VAL="${BIN_VAL}${BIN_DIGITS[$ARR_POS]}"
		ARR_POS=$(($ARR_POS-1))
	done
fi

echo -e "${DEC_VAL} converted to binary equals:\n${BIN_VAL}"
