namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kINUhld7PUSFGL4fj4MgfA)
///  <code>RC_680b4f2b38f7607d61faf8ef68fd2613</code> that represents <code>TaxIndicatorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TaxIndicatorRecord
public partial struct RC_680b4f2b38f7607d61faf8ef68fd2613 : ITypedRecord<RC_680b4f2b38f7607d61faf8ef68fd2613> {
internal static readonly GlobalObjectKey IdTaxIndicator = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*K08LaPc4fWBh+vjvaP0mEw");

public EN_efc751d189a1545503ba31ced5225e86EntityRecord ssENTaxIndicator;


public static implicit operator EN_efc751d189a1545503ba31ced5225e86EntityRecord( RC_680b4f2b38f7607d61faf8ef68fd2613 r) {
return r.ssENTaxIndicator;
}

public static implicit operator RC_680b4f2b38f7607d61faf8ef68fd2613 (EN_efc751d189a1545503ba31ced5225e86EntityRecord r) {
RC_680b4f2b38f7607d61faf8ef68fd2613 res = new RC_680b4f2b38f7607d61faf8ef68fd2613 ();
res.ssENTaxIndicator = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENTaxIndicator.ChangedAttributes = value;
}
get {
    return ssENTaxIndicator.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_680b4f2b38f7607d61faf8ef68fd2613() {
OptimizedAttributes = null;
ssENTaxIndicator = new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENTaxIndicator.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENTaxIndicator.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENTaxIndicator.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENTaxIndicator.Read( r, ref index);
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
public void ReadIM(RC_680b4f2b38f7607d61faf8ef68fd2613 r) {
this = r;
}


public static bool operator == (RC_680b4f2b38f7607d61faf8ef68fd2613 a, RC_680b4f2b38f7607d61faf8ef68fd2613 b) {
if (a.ssENTaxIndicator != b.ssENTaxIndicator) return false;
return true;
}

public static bool operator != (RC_680b4f2b38f7607d61faf8ef68fd2613 a, RC_680b4f2b38f7607d61faf8ef68fd2613 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_680b4f2b38f7607d61faf8ef68fd2613)) return false;
return (this == (RC_680b4f2b38f7607d61faf8ef68fd2613)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENTaxIndicator.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENTaxIndicator.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENTaxIndicator.InternalRecursiveSave();
}


public RC_680b4f2b38f7607d61faf8ef68fd2613 Duplicate() {
RC_680b4f2b38f7607d61faf8ef68fd2613 t;
t.ssENTaxIndicator = (EN_efc751d189a1545503ba31ced5225e86EntityRecord)this.ssENTaxIndicator.Duplicate();
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
if (head == "taxindicator") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TaxIndicator")) variable.Value = ssENTaxIndicator; else variable.Optimized = true;
variable.SetFieldName("taxindicator");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENTaxIndicator.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENTaxIndicator.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTaxIndicator) {
return ssENTaxIndicator;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTaxIndicator.Key.AsGuid) {
return ssENTaxIndicator;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENTaxIndicator.FillFromOther((IRecord) other.AttributeGet(IdTaxIndicator));
}
} // RC_680b4f2b38f7607d61faf8ef68fd2613
/// <summary>
/// RecordList type <code>TaxIndicatorRecordList</code> that represents a record list of
///  <code>TaxIndicator</code>
/// </summary>
public partial class RL_bf188616de0f0f2f6ca06ba5dba27490 : GenericRecordList<RC_680b4f2b38f7607d61faf8ef68fd2613>, IEnumerable, IEnumerator {

protected override RC_680b4f2b38f7607d61faf8ef68fd2613 GetElementDefaultValue() {
return new RC_680b4f2b38f7607d61faf8ef68fd2613();
}

public T[] ToArray<T>(Func<RC_680b4f2b38f7607d61faf8ef68fd2613, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_bf188616de0f0f2f6ca06ba5dba27490 recordList, Func<RC_680b4f2b38f7607d61faf8ef68fd2613, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_bf188616de0f0f2f6ca06ba5dba27490(RC_680b4f2b38f7607d61faf8ef68fd2613[] array) {
  RL_bf188616de0f0f2f6ca06ba5dba27490 result = new RL_bf188616de0f0f2f6ca06ba5dba27490();
result.InnerFromArray(array);
    return result;
}

public static RL_bf188616de0f0f2f6ca06ba5dba27490 ToList<T>(T[] array, Func <T, RC_680b4f2b38f7607d61faf8ef68fd2613> converter) {
  RL_bf188616de0f0f2f6ca06ba5dba27490 result = new RL_bf188616de0f0f2f6ca06ba5dba27490();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_bf188616de0f0f2f6ca06ba5dba27490 FromRestList<T>(RestList<T> restList, Func <T, RC_680b4f2b38f7607d61faf8ef68fd2613> converter) {
  RL_bf188616de0f0f2f6ca06ba5dba27490 result = new RL_bf188616de0f0f2f6ca06ba5dba27490();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_bf188616de0f0f2f6ca06ba5dba27490() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_680b4f2b38f7607d61faf8ef68fd2613> NewList() {
return new RL_bf188616de0f0f2f6ca06ba5dba27490();
}


} // RL_bf188616de0f0f2f6ca06ba5dba27490
}

