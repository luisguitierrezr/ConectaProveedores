namespace ssConectaProveedores {
/// <summary>
/// [Structure] ErroImport (qMAMsp2gAUGwuO2GpfLhcQ)
///  <code>ST_37eba272293c59d7cf1400fbd0fb4b40Structure</code> that represents <code>ErroImport</code
/// > <p>Description: Struct for import error in proposal lines</p>
/// </summary>
// Name: ErroImport
public partial struct ST_37eba272293c59d7cf1400fbd0fb4b40Structure : ITypedRecord<ST_37eba272293c59d7cf1400fbd0fb4b40Structure> {
internal static readonly GlobalObjectKey IdDocument = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lxmc1TFQmUOwQc2aDTfmDA");
internal static readonly GlobalObjectKey IdError = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WK71JCtqbUCMmth+bAOeyg");

public string ssDocument;

public string ssError;


public BitArray OptimizedAttributes;

public ST_37eba272293c59d7cf1400fbd0fb4b40Structure() {
OptimizedAttributes = null;
ssDocument = "";
ssError = "";
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
ssDocument = r.ReadText(index++, "ErroImport.Document", "");
ssError = r.ReadText(index++, "ErroImport.Error", "");
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
public void ReadIM(ST_37eba272293c59d7cf1400fbd0fb4b40Structure r) {
this = r;
}


public static bool operator == (ST_37eba272293c59d7cf1400fbd0fb4b40Structure a, ST_37eba272293c59d7cf1400fbd0fb4b40Structure b) {
if (a.ssDocument != b.ssDocument) return false;
if (a.ssError != b.ssError) return false;
return true;
}

public static bool operator != (ST_37eba272293c59d7cf1400fbd0fb4b40Structure a, ST_37eba272293c59d7cf1400fbd0fb4b40Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_37eba272293c59d7cf1400fbd0fb4b40Structure)) return false;
return (this == (ST_37eba272293c59d7cf1400fbd0fb4b40Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDocument.GetHashCode()
 ^ ssError.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_37eba272293c59d7cf1400fbd0fb4b40Structure Duplicate() {
ST_37eba272293c59d7cf1400fbd0fb4b40Structure t;
t.ssDocument = this.ssDocument;
t.ssError = this.ssError;
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
if (head == "document") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Document")) variable.Value = ssDocument; else variable.Optimized = true;
} else if (head == "error") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Error")) variable.Value = ssError; else variable.Optimized = true;
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
if (key == IdDocument) {
return ssDocument;
}
if (key == IdError) {
return ssError;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocument.Key.AsGuid) {
return ssDocument;
}
if (attributeKey == IdError.Key.AsGuid) {
return ssError;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDocument = (string) other.AttributeGet(IdDocument);
ssError = (string) other.AttributeGet(IdError);
}
} // ST_37eba272293c59d7cf1400fbd0fb4b40Structure
/// <summary>
/// RecordList type <code>ErroImportList</code> that represents a record list of
///  <code>ErroImport</code>
/// </summary>
public partial class RL_21421685308149cb9c93dd790730a8ac : GenericRecordList<ST_37eba272293c59d7cf1400fbd0fb4b40Structure>, IEnumerable, IEnumerator {

protected override ST_37eba272293c59d7cf1400fbd0fb4b40Structure GetElementDefaultValue() {
return new ST_37eba272293c59d7cf1400fbd0fb4b40Structure();
}

public T[] ToArray<T>(Func<ST_37eba272293c59d7cf1400fbd0fb4b40Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_21421685308149cb9c93dd790730a8ac recordList, Func<ST_37eba272293c59d7cf1400fbd0fb4b40Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_21421685308149cb9c93dd790730a8ac(ST_37eba272293c59d7cf1400fbd0fb4b40Structure[] array) {
  RL_21421685308149cb9c93dd790730a8ac result = new RL_21421685308149cb9c93dd790730a8ac();
result.InnerFromArray(array);
    return result;
}

public static RL_21421685308149cb9c93dd790730a8ac ToList<T>(T[] array, Func <T, ST_37eba272293c59d7cf1400fbd0fb4b40Structure> converter) {
  RL_21421685308149cb9c93dd790730a8ac result = new RL_21421685308149cb9c93dd790730a8ac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_21421685308149cb9c93dd790730a8ac FromRestList<T>(RestList<T> restList, Func <T, ST_37eba272293c59d7cf1400fbd0fb4b40Structure> converter) {
  RL_21421685308149cb9c93dd790730a8ac result = new RL_21421685308149cb9c93dd790730a8ac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_21421685308149cb9c93dd790730a8ac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_37eba272293c59d7cf1400fbd0fb4b40Structure> NewList() {
return new RL_21421685308149cb9c93dd790730a8ac();
}


} // RL_21421685308149cb9c93dd790730a8ac
}

