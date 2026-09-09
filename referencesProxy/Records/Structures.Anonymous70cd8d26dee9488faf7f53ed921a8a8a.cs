namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Jo3NcOnej0ivf1PtkhqKig)
///  <code>RC_2e0c106d4606a1153081317391234712</code> that represents <code>TI_POS_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_POS_InRecord
public partial struct RC_2e0c106d4606a1153081317391234712 : ITypedRecord<RC_2e0c106d4606a1153081317391234712> {
internal static readonly GlobalObjectKey IdTI_POS_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bRAMLgZGFaEwgTFzkSNHEg");

public ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure ssSTTI_POS_In;


public static implicit operator ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure( RC_2e0c106d4606a1153081317391234712 r) {
return r.ssSTTI_POS_In;
}

public static implicit operator RC_2e0c106d4606a1153081317391234712 (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure r) {
RC_2e0c106d4606a1153081317391234712 res = new RC_2e0c106d4606a1153081317391234712 ();
res.ssSTTI_POS_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2e0c106d4606a1153081317391234712() {
OptimizedAttributes = null;
ssSTTI_POS_In = new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure();
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
    ssSTTI_POS_In.OptimizedAttributes = value[0];
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
ssSTTI_POS_In.Read( r, ref index);
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
public void ReadIM(RC_2e0c106d4606a1153081317391234712 r) {
this = r;
}


public static bool operator == (RC_2e0c106d4606a1153081317391234712 a, RC_2e0c106d4606a1153081317391234712 b) {
if (a.ssSTTI_POS_In != b.ssSTTI_POS_In) return false;
return true;
}

public static bool operator != (RC_2e0c106d4606a1153081317391234712 a, RC_2e0c106d4606a1153081317391234712 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2e0c106d4606a1153081317391234712)) return false;
return (this == (RC_2e0c106d4606a1153081317391234712)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_POS_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_POS_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_POS_In.InternalRecursiveSave();
}


public RC_2e0c106d4606a1153081317391234712 Duplicate() {
RC_2e0c106d4606a1153081317391234712 t;
t.ssSTTI_POS_In = (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure)this.ssSTTI_POS_In.Duplicate();
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
if (head == "ti_pos_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_POS_In")) variable.Value = ssSTTI_POS_In; else variable.Optimized = true;
variable.SetFieldName("ti_pos_in");
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
if (key == IdTI_POS_In) {
return ssSTTI_POS_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_POS_In.Key.AsGuid) {
return ssSTTI_POS_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_POS_In.FillFromOther((IRecord) other.AttributeGet(IdTI_POS_In));
}
} // RC_2e0c106d4606a1153081317391234712
/// <summary>
/// RecordList type <code>TI_POS_InRecordList</code> that represents a record list of
///  <code>TI_POS_In</code>
/// </summary>
public partial class RL_df7ff2321a7f9dd30c57167fb550eba1 : GenericRecordList<RC_2e0c106d4606a1153081317391234712>, IEnumerable, IEnumerator {

protected override RC_2e0c106d4606a1153081317391234712 GetElementDefaultValue() {
return new RC_2e0c106d4606a1153081317391234712();
}

public T[] ToArray<T>(Func<RC_2e0c106d4606a1153081317391234712, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_df7ff2321a7f9dd30c57167fb550eba1 recordList, Func<RC_2e0c106d4606a1153081317391234712, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_df7ff2321a7f9dd30c57167fb550eba1(RC_2e0c106d4606a1153081317391234712[] array) {
  RL_df7ff2321a7f9dd30c57167fb550eba1 result = new RL_df7ff2321a7f9dd30c57167fb550eba1();
result.InnerFromArray(array);
    return result;
}

public static RL_df7ff2321a7f9dd30c57167fb550eba1 ToList<T>(T[] array, Func <T, RC_2e0c106d4606a1153081317391234712> converter) {
  RL_df7ff2321a7f9dd30c57167fb550eba1 result = new RL_df7ff2321a7f9dd30c57167fb550eba1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_df7ff2321a7f9dd30c57167fb550eba1 FromRestList<T>(RestList<T> restList, Func <T, RC_2e0c106d4606a1153081317391234712> converter) {
  RL_df7ff2321a7f9dd30c57167fb550eba1 result = new RL_df7ff2321a7f9dd30c57167fb550eba1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_df7ff2321a7f9dd30c57167fb550eba1() : base() {
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
protected override OSList<RC_2e0c106d4606a1153081317391234712> NewList() {
return new RL_df7ff2321a7f9dd30c57167fb550eba1();
}


} // RL_df7ff2321a7f9dd30c57167fb550eba1
}

