namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CiR26MRvsUqSBKld47zTPw)
///  <code>RC_53151840a12237c01ba8b6380f8a7866</code> that represent
/// s <code>CurrentAccountFACT_PEN_PAGStructRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrentAccountFACT_PEN_PAGStructRecord
public partial struct RC_53151840a12237c01ba8b6380f8a7866 : ITypedRecord<RC_53151840a12237c01ba8b6380f8a7866> {
internal static readonly GlobalObjectKey IdCurrentAccountFACT_PEN_PAGStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*QBgVUyKhwDcbqLY4D4p4Zg");

public ST_6e58a6c07a695cdbbb36aed76c927a26Structure ssSTCurrentAccountFACT_PEN_PAGStruct;


public static implicit operator ST_6e58a6c07a695cdbbb36aed76c927a26Structure( RC_53151840a12237c01ba8b6380f8a7866 r) {
return r.ssSTCurrentAccountFACT_PEN_PAGStruct;
}

public static implicit operator RC_53151840a12237c01ba8b6380f8a7866 (ST_6e58a6c07a695cdbbb36aed76c927a26Structure r) {
RC_53151840a12237c01ba8b6380f8a7866 res = new RC_53151840a12237c01ba8b6380f8a7866 ();
res.ssSTCurrentAccountFACT_PEN_PAGStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_53151840a12237c01ba8b6380f8a7866() {
OptimizedAttributes = null;
ssSTCurrentAccountFACT_PEN_PAGStruct = new ST_6e58a6c07a695cdbbb36aed76c927a26Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCurrentAccountFACT_PEN_PAGStruct.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTCurrentAccountFACT_PEN_PAGStruct.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_53151840a12237c01ba8b6380f8a7866 r) {
this = r;
}


public static bool operator == (RC_53151840a12237c01ba8b6380f8a7866 a, RC_53151840a12237c01ba8b6380f8a7866 b) {
if (a.ssSTCurrentAccountFACT_PEN_PAGStruct != b.ssSTCurrentAccountFACT_PEN_PAGStruct) return false;
return true;
}

public static bool operator != (RC_53151840a12237c01ba8b6380f8a7866 a, RC_53151840a12237c01ba8b6380f8a7866 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_53151840a12237c01ba8b6380f8a7866)) return false;
return (this == (RC_53151840a12237c01ba8b6380f8a7866)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCurrentAccountFACT_PEN_PAGStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCurrentAccountFACT_PEN_PAGStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCurrentAccountFACT_PEN_PAGStruct.InternalRecursiveSave();
}


public RC_53151840a12237c01ba8b6380f8a7866 Duplicate() {
RC_53151840a12237c01ba8b6380f8a7866 t;
t.ssSTCurrentAccountFACT_PEN_PAGStruct = (ST_6e58a6c07a695cdbbb36aed76c927a26Structure)this.ssSTCurrentAccountFACT_PEN_PAGStruct.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "currentaccountfact_pen_pagstruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrentAccountFACT_PEN_PAGStruct")) variable.Value = ssSTCurrentAccountFACT_PEN_PAGStruct; else variable.Optimized = true;
variable.SetFieldName("currentaccountfact_pen_pagstruct");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCurrentAccountFACT_PEN_PAGStruct) {
return ssSTCurrentAccountFACT_PEN_PAGStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrentAccountFACT_PEN_PAGStruct.Key.AsGuid) {
return ssSTCurrentAccountFACT_PEN_PAGStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCurrentAccountFACT_PEN_PAGStruct.FillFromOther((IRecord) other.AttributeGet(IdCurrentAccountFACT_PEN_PAGStruct));
}
} // RC_53151840a12237c01ba8b6380f8a7866
/// <summary>
/// RecordList type <code>CurrentAccountFACT_PEN_PAGStructRecordList</code> that represents a record
///  list of <code>CurrentAccountFACT_PEN_PAGStruct</code>
/// </summary>
public partial class RL_ad51dd9c16f367b4d82f892f85deebc0 : GenericRecordList<RC_53151840a12237c01ba8b6380f8a7866>, IEnumerable, IEnumerator {

protected override RC_53151840a12237c01ba8b6380f8a7866 GetElementDefaultValue() {
return new RC_53151840a12237c01ba8b6380f8a7866();
}

public T[] ToArray<T>(Func<RC_53151840a12237c01ba8b6380f8a7866, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ad51dd9c16f367b4d82f892f85deebc0 recordList, Func<RC_53151840a12237c01ba8b6380f8a7866, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ad51dd9c16f367b4d82f892f85deebc0(RC_53151840a12237c01ba8b6380f8a7866[] array) {
  RL_ad51dd9c16f367b4d82f892f85deebc0 result = new RL_ad51dd9c16f367b4d82f892f85deebc0();
result.InnerFromArray(array);
    return result;
}

public static RL_ad51dd9c16f367b4d82f892f85deebc0 ToList<T>(T[] array, Func <T, RC_53151840a12237c01ba8b6380f8a7866> converter) {
  RL_ad51dd9c16f367b4d82f892f85deebc0 result = new RL_ad51dd9c16f367b4d82f892f85deebc0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ad51dd9c16f367b4d82f892f85deebc0 FromRestList<T>(RestList<T> restList, Func <T, RC_53151840a12237c01ba8b6380f8a7866> converter) {
  RL_ad51dd9c16f367b4d82f892f85deebc0 result = new RL_ad51dd9c16f367b4d82f892f85deebc0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ad51dd9c16f367b4d82f892f85deebc0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_53151840a12237c01ba8b6380f8a7866> NewList() {
return new RL_ad51dd9c16f367b4d82f892f85deebc0();
}


} // RL_ad51dd9c16f367b4d82f892f85deebc0
}

