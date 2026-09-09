namespace ssConectaProveedores {
/// <summary>
/// [Structure] Step (i3LV7VYv3kCOatw_oMVPaA) <code>ST_d1e6f35068707165b6684293e397ea3bStructure</code>
///  that represents <code>Step</code> <p>Description: Step Structure.</p>
/// </summary>
// Name: Step
public partial struct ST_d1e6f35068707165b6684293e397ea3bStructure : ITypedRecord<ST_d1e6f35068707165b6684293e397ea3bStructure> {
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nOblD5vYiEyqG2eK+mwCzA");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QUtAV6drh0a10dBioDzBew");
internal static readonly GlobalObjectKey IdExtendedClass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*d3TwiN3Tbkm_GaN3ycdAJQ");
internal static readonly GlobalObjectKey IdUnderLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*t4X6kkCYxkq_bhfmv_QSVA");
internal static readonly GlobalObjectKey IdUnderLabelNChar = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*isNFGCUg1kaO6aWMwiCoHQ");

public int ssOrder;

public string ssLabel;

public string ssExtendedClass;

public string ssUnderLabel;

public int ssUnderLabelNChar;


public BitArray OptimizedAttributes;

public ST_d1e6f35068707165b6684293e397ea3bStructure() {
OptimizedAttributes = null;
ssOrder = 0;
ssLabel = "";
ssExtendedClass = "";
ssUnderLabel = "";
ssUnderLabelNChar = 0;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssOrder = r.ReadInteger(index++, "Step.Order", 0);
ssLabel = r.ReadText(index++, "Step.Label", "");
ssExtendedClass = r.ReadText(index++, "Step.ExtendedClass", "");
ssUnderLabel = r.ReadText(index++, "Step.UnderLabel", "");
ssUnderLabelNChar = r.ReadInteger(index++, "Step.UnderLabelNChar", 0);
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
public void ReadIM(ST_d1e6f35068707165b6684293e397ea3bStructure r) {
this = r;
}


public static bool operator == (ST_d1e6f35068707165b6684293e397ea3bStructure a, ST_d1e6f35068707165b6684293e397ea3bStructure b) {
if (a.ssOrder != b.ssOrder) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssExtendedClass != b.ssExtendedClass) return false;
if (a.ssUnderLabel != b.ssUnderLabel) return false;
if (a.ssUnderLabelNChar != b.ssUnderLabelNChar) return false;
return true;
}

public static bool operator != (ST_d1e6f35068707165b6684293e397ea3bStructure a, ST_d1e6f35068707165b6684293e397ea3bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d1e6f35068707165b6684293e397ea3bStructure)) return false;
return (this == (ST_d1e6f35068707165b6684293e397ea3bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssExtendedClass.GetHashCode()
 ^ ssUnderLabel.GetHashCode()
 ^ ssUnderLabelNChar.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d1e6f35068707165b6684293e397ea3bStructure Duplicate() {
ST_d1e6f35068707165b6684293e397ea3bStructure t;
t.ssOrder = this.ssOrder;
t.ssLabel = this.ssLabel;
t.ssExtendedClass = this.ssExtendedClass;
t.ssUnderLabel = this.ssUnderLabel;
t.ssUnderLabelNChar = this.ssUnderLabelNChar;
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
if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "extendedclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExtendedClass")) variable.Value = ssExtendedClass; else variable.Optimized = true;
} else if (head == "underlabel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnderLabel")) variable.Value = ssUnderLabel; else variable.Optimized = true;
} else if (head == "underlabelnchar") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnderLabelNChar")) variable.Value = ssUnderLabelNChar; else variable.Optimized = true;
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
if (key == IdOrder) {
return ssOrder;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdExtendedClass) {
return ssExtendedClass;
}
if (key == IdUnderLabel) {
return ssUnderLabel;
}
if (key == IdUnderLabelNChar) {
return ssUnderLabelNChar;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdExtendedClass.Key.AsGuid) {
return ssExtendedClass;
}
if (attributeKey == IdUnderLabel.Key.AsGuid) {
return ssUnderLabel;
}
if (attributeKey == IdUnderLabelNChar.Key.AsGuid) {
return ssUnderLabelNChar;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrder = (int) other.AttributeGet(IdOrder);
ssLabel = (string) other.AttributeGet(IdLabel);
ssExtendedClass = (string) other.AttributeGet(IdExtendedClass);
ssUnderLabel = (string) other.AttributeGet(IdUnderLabel);
ssUnderLabelNChar = (int) other.AttributeGet(IdUnderLabelNChar);
}
} // ST_d1e6f35068707165b6684293e397ea3bStructure
/// <summary>
/// RecordList type <code>StepList</code> that represents a record list of <code>Step</code>
/// </summary>
public partial class RL_81ae50f1dcaa120f946ab0b12a629a47 : GenericRecordList<ST_d1e6f35068707165b6684293e397ea3bStructure>, IEnumerable, IEnumerator {

protected override ST_d1e6f35068707165b6684293e397ea3bStructure GetElementDefaultValue() {
return new ST_d1e6f35068707165b6684293e397ea3bStructure();
}

public T[] ToArray<T>(Func<ST_d1e6f35068707165b6684293e397ea3bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_81ae50f1dcaa120f946ab0b12a629a47 recordList, Func<ST_d1e6f35068707165b6684293e397ea3bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_81ae50f1dcaa120f946ab0b12a629a47(ST_d1e6f35068707165b6684293e397ea3bStructure[] array) {
  RL_81ae50f1dcaa120f946ab0b12a629a47 result = new RL_81ae50f1dcaa120f946ab0b12a629a47();
result.InnerFromArray(array);
    return result;
}

public static RL_81ae50f1dcaa120f946ab0b12a629a47 ToList<T>(T[] array, Func <T, ST_d1e6f35068707165b6684293e397ea3bStructure> converter) {
  RL_81ae50f1dcaa120f946ab0b12a629a47 result = new RL_81ae50f1dcaa120f946ab0b12a629a47();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_81ae50f1dcaa120f946ab0b12a629a47 FromRestList<T>(RestList<T> restList, Func <T, ST_d1e6f35068707165b6684293e397ea3bStructure> converter) {
  RL_81ae50f1dcaa120f946ab0b12a629a47 result = new RL_81ae50f1dcaa120f946ab0b12a629a47();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_81ae50f1dcaa120f946ab0b12a629a47() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d1e6f35068707165b6684293e397ea3bStructure> NewList() {
return new RL_81ae50f1dcaa120f946ab0b12a629a47();
}


} // RL_81ae50f1dcaa120f946ab0b12a629a47
}

